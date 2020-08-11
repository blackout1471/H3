import { Component, OnInit } from '@angular/core';
import { Tweet } from '../tweet';
import { TweetsService } from '../tweets.service';

@Component({
  selector: 'app-tweets',
  templateUrl: './tweets.component.html',
  styleUrls: ['./tweets.component.css']
})
export class TweetsComponent implements OnInit {
  twat: Tweet[];
  constructor(tService: TweetsService) {
       this.twat = tService.tweets;
       console.log(this.twat.length);
   }

  ngOnInit() {
  }

  DoesHappyExists(text: string): boolean {
    if (text.includes("happy"))
      return true;

    return false;
  }

  IsTweetFromMayAndHasLikes(tweet: Tweet) {
    if (tweet.date.getMonth() == 2 && tweet.likes < 200000)
      return true;

    return false;
  }

}
