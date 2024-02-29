public static class Utils{

    public static bool IsLeap(int year){

        return year%400==0 || ((year%100!=0) && year%4==0);
    }

    public static string WhichSeason(int day, int month){
        return "TODO";
    }
}