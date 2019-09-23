using System;

// back end
class Clock
{
  static void Calculator(float hours, float minutes)
  {
    float hoursDegree = (hours + (minutes/60))*30;
    float minutesDegree = (minutes)*6;
    float angleRough = 0;
    if (hoursDegree >= minutesDegree)
      {
        angleRough = hoursDegree - minutesDegree;
      }
    else if (hoursDegree < minutesDegree)
    {
      angleRough = minutesDegree - hoursDegree;
    }
    else
    {
      Console.WriteLine("Enter a time Dummy!");
    }
    if (angleRough > 180)
    {
      angleRough = 360 - angleRough;
    }
    string angle = angleRough.ToString();
    Console.WriteLine("The angle between the hour and minute hand is: " + angle + " degrees");
  }




// front end
  static void Main()
  {
    Console.WriteLine("What time is it?");
    string timeString = Console.ReadLine();
    string [] split = timeString.Split(new Char [] {':'});
    string hourString = split[0];
    string minuteString = split[1];
    float hourInt = float.Parse(hourString);
    if (hourInt == 12)
    {
      hourInt = 0;
    }
    float minuteInt = float.Parse(minuteString);
    Calculator(hourInt, minuteInt);
  }
}
