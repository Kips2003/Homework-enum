namespace Homework.Extension{
    public static class DateTimeExtension{
        public static DateTime Min(this DateTime date, DateTime time){
            return (date<time)?date:time;
        }

        public static DateTime Max(this DateTime date, DateTime time){
            return (date>time)?date:time;
        }

        public static DateTime BeginingOfMonth(this DateTime date){
            return date.AddDays(-(date.Day-1));
        }

        public static DateTime EndOfMonth(this DateTime date){
            var lastDayOfMonth = DateTime.DaysInMonth(date.Year,date.Month);
            return date.AddDays(lastDayOfMonth-date.Day);
        }

        
    }
}