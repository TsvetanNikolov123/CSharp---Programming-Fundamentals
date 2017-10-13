namespace _19.TheaThePhotographer
{
    using System;

    public class TheaThePhotographer
    {
        public static void Main()
        {
            //  THE NUMBER OF PICTURES THEA HAD TAKEN.
            long numberOfPictures = long.Parse(Console.ReadLine());

            //  THE AMOUNT OF TIME (FILTER TIME) IN SECONDS
            long filterTime = long.Parse(Console.ReadLine());

            //  THE PERCENTAGE OF THE TOTAL PICTURES THAT ARE CONSIDERED “good” TO BE UPLOADED
            long filterFactor = long.Parse(Console.ReadLine());

            //  THE AMOUNT OF TIME NEEDED FOR EVERY FILTERED PICTURE TO BE UPLOADED
            long uploadTime = long.Parse(Console.ReadLine());

            long filteredPictures =(long)( Math.Ceiling(numberOfPictures * (filterFactor / 100.0)));
            long timeToFiltering = numberOfPictures * filterTime;
            long timeToUpload = filteredPictures * uploadTime;
            long totalTime = timeToFiltering + timeToUpload;

            long seconds = totalTime % 60;
            totalTime /= 60;
            long minutes = totalTime % 60;
            totalTime /= 60;
            long hour = totalTime % 24;
            totalTime /= 24;
            long days = totalTime;

            Console.WriteLine($"{days}:{hour:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
