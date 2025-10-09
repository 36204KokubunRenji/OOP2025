using System;
using System.Timers;

public class RealTimeClock {
    private static System.Timers.Timer timer;
    private static int interval = 1000; // 1秒ごとに更新

    public static void Main(string[] args) {
        timer = new System.Timers.Timer(interval);
        timer.Elapsed += UpdateClock;
        timer.AutoReset = true; // 繰り返し実行
        timer.Enabled = true; // タイマーを開始

        Console.WriteLine("リアルタイム時計を開始します。終了するには何かキーを押してください。");
        Console.ReadKey();

        timer.Stop();
        timer.Dispose();
    }

    private static void UpdateClock(Object source, ElapsedEventArgs e) {
        DateTime now = DateTime.Now;
        Console.Clear();
        Console.WriteLine(now.ToString("yyyy/MM/dd HH:mm:ss"));
    }
}