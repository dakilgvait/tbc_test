import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { TestService } from './services/test-service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'TestClient';
  data!: Observable<any>;

  constructor(private testService: TestService) {
  }


  ngOnInit(): void {
    this.data = this.testService.getTest();

  }

  getData(): void {
   
      


  }
}
