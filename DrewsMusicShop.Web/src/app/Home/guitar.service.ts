import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

import { Guitar } from "./guitar";

@Injectable()
export class GuitarService {
    private url = "api/guitarApi";

    constructor(private http: Http) {
    }

    getGuitars(): Observable<Guitar[]> {
        return this.http.get(this.url).map(this.extractData).catch(this.handleErrors);
    }

    private extractData(res: Response) {
        let body = res.json();
        return body || {};
    }

    private handleErrors(error: any): Observable<any> {
        let errors: string[] = [];
        switch (error.status) {
            case 404: // Not Found
                errors.push("No Guitar Data Is Available.");
                break;
            case 500: // Internal Error
                errors.push(error.json().exceptionMessage);
                break;
            default:
                errors.push("Status: " + error.status
                    + " - Error Message: "
                    + error.statusText);
                break;
        };
        console.error('An error occurred', errors);
        return Observable.throw(errors);
    }
}