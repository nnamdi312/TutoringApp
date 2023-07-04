import { Component } from '@angular/core';
import{HttpClient} from '@angular/common/http';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'client'; 
constructor(private http: HttpClient){

}
ngOnInit(): void{
  debugger;
  this.http.get("http://localhost:5082/users").subscribe(users=>console.log(users));
}
}
