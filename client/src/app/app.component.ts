import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})                        //implementiramo OnInit
export class AppComponent implements OnInit {
  title = 'The Dating app';
  users: any; //sa any se narusava type safety

  // dependecy injection
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getUsers();
  }

  getUsers() {
    // pomocu subscribe metode ukazujemo sta sledece da se radi
   // sta u slucaju greske i sta po zavrsenju
   this.http.get('https://localhost:5001/api/users').subscribe(response => {
     this.users = response; // u response se nalaze nasi useri i to dodeljujemo promenljivoj users
     // da bismo dobili odgovore treba na CORS - Cross Origin Resource Sharing
    }, error => {
      console.log(error);

    })
  }

}
