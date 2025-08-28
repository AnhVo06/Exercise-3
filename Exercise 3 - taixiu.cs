using System.Runtime;

internal class Program
{
    private static void Main(string[] args)
    {
        game_engine();
    }
    static void game_engine()
    { /*Viết chương trình biểu diễn trò chơi Tài-Xỉu với 2 con xúc sắc.
       *Máy tính gieo 2 con xúc sắc và lấy tổng của chúng, nếu lơn hơn 5 thì là "Tài", nhỏ hơn 5 là "Xỉu", Bằng 5 là trường hợp đặc biệt.
       *Máy sẽ hỏi người chơi đoán Tài/Xỉu/5. Nếu người chơi đoán đúng/sai tài/xỉu thì thắng +5$/-5$. Đoán trúng số 5 thì cộng gấp 3 (thua thì trừ 5).
       *Giả sử ban đầu người chơi có 100$, chương trình sẽ chơi cho đến thi hết tiền hoặc người chơi chọn ngưng chơi.
       *Sau khi kết thúc, làm một báo cáo tổng hợp.
       */
        Console.WriteLine("\nChao mung den voi tro Tai Xiu\n");
        int money = 100;
        int wincount = 0;
        int losecount = 0;
        do
        {
            Random rand = new Random();
            int dice1 = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);
            int sum = dice1 + dice2;
            Console.WriteLine("Ban doan Tai hay Xiu hay 5");
            string tl = Console.ReadLine().ToLower();
            if (tl != "tai" && tl != "xiu" && tl != "5")
            {
                Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                continue;
            }
            if (sum > 5)
            {
                Console.WriteLine("Ket qua la Tai");
                if (tl == "tai")
                {
                    Console.WriteLine("Ban thang va duoc +5$");
                    money += 5;
                    wincount++;
                }
                else
                {
                    Console.WriteLine("Ban thua va bi -5$");
                    money -= 5;
                    losecount++;
                }
            }
            else if (sum < 5)
            {
                Console.WriteLine("Ket qua la Xiu");
                if (tl == "xiu")
                {
                    Console.WriteLine("Ban thang va duoc +5$");
                    money += 5;
                    wincount++;
                }
                else
                {
                    Console.WriteLine("Ban thua va bi -5$");
                    money -= 5;
                    losecount++;
                }
            }
            else
            {
                Console.WriteLine("Ket qua la 5");
                if (tl == "5")
                {
                    Console.WriteLine("Ban thang va duoc +15$");
                    money += 15;
                    wincount++;
                }
                else
                {
                    Console.WriteLine("Ban thua va bi -5$");
                    money -= 5;
                    losecount++;
                }
            }
            Console.WriteLine($"Tong so tien hien tai la {money}");
            if (money <= 0)
            {
                Console.WriteLine("Ban da het tien!");
                break;
            }
            string choice;
            do
            {
                Console.WriteLine("Ban co muon tiep tuc choi khong? <c/k>");
                choice = Console.ReadLine().ToLower();
                if (choice != "k" && choice != "c")
                {
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                }
            }
            while (choice != "k" && choice != "c");
            if (choice == "k")
            {
                break;
            }
            } while (true) ;
        Console.WriteLine("\nGAME OVER");
        Console.WriteLine($"Tong so van thang: {wincount}, thua: {losecount}, so tien sau cung la {money}$");
    }
}
