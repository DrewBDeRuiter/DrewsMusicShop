import { NgModule } from '@angular/core'
import { RouterModule, Routes } from '@angular/router'

import { WelcomeComponent } from './Home/welcome.component';

const routes: Routes = [

    {
        path: 'Home',
        component: WelcomeComponent},
    {
        //path: 'Product/Product',
        //redirectTo: 'productList'
    }
]


@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }