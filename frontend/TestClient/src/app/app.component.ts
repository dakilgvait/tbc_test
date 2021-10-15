import { Component } from '@angular/core';
import { TestService } from './services/test-service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'TestClient';
  data: any;

  constructor(private testService: TestService) { 
    this.getData();
  }

  getData(): void {
    this.testService.getTest().subscribe((res) => {
      console.log(res);
      this.data = res;

    })

  }
}
