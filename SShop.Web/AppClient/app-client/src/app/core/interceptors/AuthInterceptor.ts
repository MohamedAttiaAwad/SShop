import { Injectable } from "@angular/core";
import {HttpEvent, HttpHandler, HttpInterceptor, HttpRequest} from  "@angular/common/http"
import { Observable } from "rxjs";


[Injectable]
export class AuthInterceptor implements HttpInterceptor {


    constructor(){

    }

    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
         const authHeader = '49a5kdkv409fd39'; // this.authService.getAuthHeader();
         const authReq = req.clone({headers: req.headers.set('Authorization',authHeader)});
         return next.handle(authReq);
    }

}