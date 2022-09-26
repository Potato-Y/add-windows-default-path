using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_windows_default_path
{
    internal class Program
    {
        private static string _path = @"C:\Windows\system32";

        static void Main(string[] args)
        {
            Console.Title = "add windows default path";

            Console.WriteLine("=====Start adding the Windows default route.=====");
            Console.WriteLine(@"additional information: " + _path + "\n");

            // 기존 Path의 내용을 가져옵니다.
            Console.WriteLine("Import existing information.\n");
            string _existingPath = System.Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);

            // 불러온 내용을 배열로 저장
            string[] arrayExistingPath = _existingPath.Split(';');
            // 새로운 Path를 위해 StringBuilder 선언
            StringBuilder newPath = new StringBuilder();

            // 기존에 추가된 환경 변수인지 확인
            if (!arrayExistingPath.Contains(_path))
            {
                // 없는 환경 변수라면 실행
                newPath.Append(_path + ";");

                foreach (string path in arrayExistingPath)
                {
                    newPath = newPath.Append(path + ";");
                }

                // 환경 변수에 적용
                try
                {
                    Console.Write("Add Path: ");
                    System.Environment.SetEnvironmentVariable("Path", newPath.ToString(), EnvironmentVariableTarget.Machine);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("success");
                }
                catch (Exception err)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep();
                    Console.Write("ERROR\n" + err.Message);
                }
            }
            // 만약 이미 존재하는 Path라면 안내 문구 반환
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("! Path that already exists.");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
