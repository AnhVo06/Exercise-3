internal class Program
{
    private static void Main(string[] args)
    {
       game_engine();
    }
    static void game_engine()
    {
        /*
         * Yêu cầu thêm: Cho 100$ là tiền quỹ, mỗi ván chơi thắng thua thì được/mất 4/7/10$ theo level.
         * Chơi cho đến khi không chơi nữa hoặc hết tiền.
         * Thống kê số ván thắng/thua, số tiền còn lại trong quỹ.
         */
        Console.WriteLine("\nChao mung den vơi tro choi doan so\n");
        int quy = 100;
        int wincount = 0;
        int losecount = 0;
        Console.WriteLine($"\nBan hien dang co {quy} trong quy\n");
        
        do
        {
            Console.WriteLine("Level: \n\tKho: 4 lan choi\n\tTrung binh: 7 lan choi\n\tDe: 10 lan choi");
            Console.Write("Ban chon level nao? [1-Kho; 2-Trung binh; 3-De]: ");
            int level;
            // Kiem tra bang TryParse
            while (!int.TryParse(Console.ReadLine(), out level) || level < 1 || level > 3)
            {
                Console.Write("Lua chon khong hop le. Vui long chon lai [1-Kho; 2-Trung binh; 3-De]: ");
            }
            int solanchoi = 10; //mặc định là dễ

                solanchoi = level == 1 ? 4 : level == 2 ? 7 : 10;

            //máy tính nghĩ ra 1 số
                        Random rand = new Random(); //công cụ nghĩ ra số ngẫu nhiên
            int comp_num = rand.Next(1, 101); //số từ 1 đến 100

            //biến lưu trữ trạng thái thua hay thắng
            bool win = false;
            //yêu cầu người dừng đoán số
            for (int i = 0; i < solanchoi; i++)
            {
                Console.WriteLine($"Ban doan so may [1-100]: ");
                int man_num;
                // Kiemtra bang TryParse
                while (!int.TryParse(Console.ReadLine(), out man_num) || man_num < 1 || man_num > 100)
                {
                    Console.Write("Lua chon khong hop le. Vui long chon lai [1-100]: ");
                }
                //so sanh ket qua
                if (man_num == comp_num)
                {
                    win = true;     
                    Console.WriteLine("You are Genius");
                    break;
                }
                else
                {
                    if  (man_num > comp_num)
                    {
                        Console.WriteLine("So ban doan lon hon so may nghi");
                    }
                    else
                    {
                        Console.WriteLine("So ban doan nho hon so may nghi");
                    }
                }
            } if (!win)
            {
                Console.WriteLine($"\nMay nghi ra so {comp_num}. Phuc khong!");
            }
            if (win)
            {
                quy += solanchoi;
                wincount++;
                Console.WriteLine($"\nBan da thang + {solanchoi}$");
            }
            else
            {
                quy -= solanchoi;
                losecount++;
                Console.WriteLine($"\nBan da thua -{solanchoi}$");
            }
            if (quy <= 0)
            {
                Console.WriteLine("\nBan da het tien! Tro choi ket thuc\n");
                break ;
            }
            //sau 1 lan choi hoi nguoi dung co choi nua khong
            string tl;
            do
            {
                Console.WriteLine("Ban co muon choi tiep khong? <c/k> ");
                tl = Console.ReadLine().ToLower();
                if (tl != "c" && tl != "k")
                {
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                }
            }
            while (tl != "c" && tl != "k");
            if (tl == "k")
            {
                break;
            }
        } while (true);
        Console.WriteLine("\nGAME OVER");
        Console.WriteLine($"\nTong so van thang: {wincount}, thua: {losecount}, so tien sau cung trong quy la: {quy}$");
    }
}