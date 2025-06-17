namespace Test01 {
    public class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);

        }

        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> Scores = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in line) {
                if (dict.ContainsKey(sale.ShopName)) {
                    dict[sale.ShopName] += sale.Amount;
                } else {
                    dict[sale.ShopName] = sale.Amount;
                }
            }
            return dict;



        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            




        }
    }
}
