import { Injectable, Output,EventEmitter,Inject, Directive } from "@angular/core";
import { HttpClient,HttpErrorResponse  } from "@angular/common/http";
import { Observable ,throwError } from "rxjs";
import { catchError, map } from "rxjs/operators";

import { IUserLogin } from "src/app/shared/interfaces";
import {UtilitiesService} from "./utilities.service"

[Injectable]
export class AuthService {
    baseUrl = this.utilitiesService.getApiUrl();
    authUrl  = this.baseUrl + '/api/auth';
    isAuthenticated = false;
    @Output() authChanged: EventEmitter<boolean> = new EventEmitter<boolean>();
 

    constructor(private http:HttpClient, private utilitiesService:UtilitiesService){

    }

    private userAuthChanged(status: boolean) {
        this.authChanged.emit(status); // Raise changed event
    }

    login(userLogin: IUserLogin): Observable<boolean>{
        return this.http.post<boolean>(this.authUrl + '/login',userLogin)
            .pipe(
                map(loggedIn => {
                    this.isAuthenticated = loggedIn;
                    this.userAuthChanged(loggedIn);
                    return loggedIn;
                })
                //,catchError(this.handleError)
            );
    }


    //private handleError(error: HttpErrorResponse) {
    //    console.error('server error:', error);
    //    if (error.error instanceof Error) {
    //      const errMessage = error.error.message;
    //      //return Observable.throw(errMessage);
    //      return throwError(errMessage);
    //      // return Observable.throw(err.text() || 'backend server error');
    //    }
    //    //return Observable.throw(error || 'Server error');
    //}
}
