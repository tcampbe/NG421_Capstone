import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-schedule',
  templateUrl: './schedule.component.html',
  /*  styleUrls: ['./schedule.component.css']
  */
})
export class ScheduleComponent implements OnInit {
  public schedules: Schedule[];
  public newSchedule: Schedule = { English: '', Math: '', Science: '', SocialStudies: '' };

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

  }
  async ngOnInit() {
    this.schedules = await this.http.get<Schedule[]>(this.baseUrl + 'schedule').toPromise();
    console.log(this.schedules);
  }
  async save() {
    await this.http.post<Schedule[]>(this.baseUrl + 'schedule', this.newSchedule).toPromise();
    this.newSchedule = { English: '', Math: '', Science: '', SocialStudies: '' };
    this.schedules = await this.http.get<Schedule[]>(this.baseUrl + 'schedule').toPromise();
  }


}

interface Schedule {
  English: string;
  Math: string;
  Science: string;
  SocialStudies: string;
}
