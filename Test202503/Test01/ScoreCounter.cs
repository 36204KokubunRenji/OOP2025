using System.Security.Cryptography.X509Certificates;

namespace Test01 {
    public class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {

            _score = ReadScore(filePath);
        }

        //メソッドの概要：
        private static IEnumerable<Student> ReadScore(string filePath) {
            var sales = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var items = line.Split(',');
                var sale = new Student{
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                sales.Add(sale);
            }







            return sales;
        }

        //メソッドの概要：
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _score) {
                if (dict.ContainsKey(sale.Name))
                    dict[sale.Name] += sale.Score;
                else
                    dict[sale.Name] = sale.Score;
            }





            return dict;
        }
    }
}
