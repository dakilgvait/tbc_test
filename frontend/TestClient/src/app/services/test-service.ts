import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
    providedIn: 'root'
})

export class TestService {
    constructor(private http: HttpClient) { }

    getTest(): Observable<any> {
        return this.http.get('http://localhost:5000/home/testaction');

    }
}