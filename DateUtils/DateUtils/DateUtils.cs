public static class Utils{

    public static bool IsLeap(int year){

        return year%400==0 || ((year%100!=0) && year%4==0);
    }

    /*
    Method WhichSeason takes as input:
        - day (int)
        - month (int)
        - year (int) 
    and it should return a string:
        - "Winter", "Spring", "August","Autumn" or "Invalid date"
      
    The input date needs to be valid. For example:
        - Month should be between 1 and 12.
        - 31st May is valid but 31st of April is invalid date.
        - 29th February is valid if the year is leap, otherwise it is not valid.
          Tip (use function IsLeap)
        - etc
    
    You should implement unit tests for WhichSeason, don't forget to check 
    boundary conditions such as 20 and 21st December, and also don't forget 
    to check invalid dates equivalent to the ones shown above.
    */
    public static string WhichSeason(int day, int month, int year){
        return "TODO";
    }
}