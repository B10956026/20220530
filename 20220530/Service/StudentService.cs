using _20220530.Models;

namespace _20220530.Service
{
    public class StudentService : IStudentService
    {
        List<Student> studentGithubs = new List<Student>();
        
        public StudentService()
        {
            studentGithubs.Add(new Student("B10756002", " 楊福安", " https://github.com/fuan0307"));
            studentGithubs.Add(new Student("B10756007", " 謝澄恩", " https://github.com/B10756007"));
            studentGithubs.Add(new Student("B10756019", " 何晏安", " https://github.com/a31965118"));
            studentGithubs.Add(new Student("B10756020", " 李佳錚", " https://github.com/judy1999"));
            studentGithubs.Add(new Student("B10756024", " 魏永盛", " https://github.com/s881121477"));
            studentGithubs.Add(new Student("B10756028", " 吳鈞盛", " https://github.com/dog5563750"));
            studentGithubs.Add(new Student("B10756043", " 林思良", " https://github.com/Samliin"));
            studentGithubs.Add(new Student("B10756051", " 陳廷宇", " https://github.com/ctyQwQ"));
            studentGithubs.Add(new Student("B10756052", " 蘇志傑", " https://github.com/B10756052"));
            studentGithubs.Add(new Student("B10756053", " 溫文漢", " https://github.com/hankwen0716"));
            studentGithubs.Add(new Student("B10856150", " 柯健偉", " https://github.com/B10856150"));
            studentGithubs.Add(new Student("B10956001", " 鄭寶源", " https://github.com/B10956001"));
            studentGithubs.Add(new Student("B10956002", " 李其翰", " https://github.com/ghkkk135"));
            studentGithubs.Add(new Student("B10956003", " 蕭伊婷", " https://github.com/I-Ting-NPUST"));
            studentGithubs.Add(new Student("B10956004", " 侯宇炯", " https://github.com/B10956004"));
            studentGithubs.Add(new Student("B10956005", " 羅品硯", " https://github.com/B10956005"));
            studentGithubs.Add(new Student("B10956006", " 陳泓瑋", " https://github.com/puma910122"));
            studentGithubs.Add(new Student("B10956007", " 陳偉智", " https://github.com/yyj218"));
            studentGithubs.Add(new Student("B10956008", " 謝采彤", " https://github.com/B10956008"));
            studentGithubs.Add(new Student("B10956009", " 陳至浩", " https://github.com/Uie9910"));
            studentGithubs.Add(new Student("B10956010", " 徐嘉妤", " https://github.com/B10956010"));
            studentGithubs.Add(new Student("B10956011", " 洪翌愷", " https://github.com/B10956011"));
            studentGithubs.Add(new Student("B10956012", " 林哲銘", " https://github.com/SeanMoln"));
            studentGithubs.Add(new Student("B10956013", " 陳振嘉", " https://github.com/UseRtWese"));
            studentGithubs.Add(new Student("B10956014", " 鄭郁潔", " https://github.com/ytut0628"));
            studentGithubs.Add(new Student("B10956016", " 林建邦", " https://github.com/TuBang0406"));
            studentGithubs.Add(new Student("B10956017", " 楊崇民", " https://github.com/B10956017"));
            studentGithubs.Add(new Student("B10956019", " 黃子豪", " https://github.com/B10956019"));
            studentGithubs.Add(new Student("B10956020", " 王伯漢", " https://github.com/Utsunomiya00500"));
            studentGithubs.Add(new Student("B10956021", " 洪珮瑜", " https://github.com/B10956021"));
            studentGithubs.Add(new Student("B10956022", " 黃子芸", " https://github.com/huang323"));
            studentGithubs.Add(new Student("B10956023", " 葉鳴宸", " https://github.com/B10956023"));
            studentGithubs.Add(new Student("B10956025", " 楊承諺", " https://github.com/TeemoCaption"));
            studentGithubs.Add(new Student("B10956026", " 謝東翰", " https://github.com/B10956026"));
            studentGithubs.Add(new Student("B10956027", " 余郁萱", " https://github.com/B10956027"));
            studentGithubs.Add(new Student("B10956028", " 廖尹聖", " https://github.com/asd27329304"));
            studentGithubs.Add(new Student("B10956029", " 陳立蓁", " https://github.com/B10956029"));
            studentGithubs.Add(new Student("B10956030", " 張凱晴", " https://github.com/B10956030"));
            studentGithubs.Add(new Student("B10956033", " 陳侑威", " https://github.com/willychen3355"));
            studentGithubs.Add(new Student("B10956034", " 姜閔傑", " https://github.com/B10956034"));
            studentGithubs.Add(new Student("B10956035", " 劉嘉昇", " https://github.com/B10956035"));
            studentGithubs.Add(new Student("B10956036", " 溫軒  ", "https://github.com/B10956036"));
            studentGithubs.Add(new Student("B10956037", " 江冠德", " https://github.com/walter13467"));
            studentGithubs.Add(new Student("B10956038", " 許殷睿", " https://github.com/daviddd0913"));
            studentGithubs.Add(new Student("B10956039", " 曾凱翔", " https://github.com/zkx0926"));
            studentGithubs.Add(new Student("B10956040", " 李振華", " https://github.com/std0613408"));
            studentGithubs.Add(new Student("B10956041", " 賴詠霖", " https://github.com/B10956041"));
            studentGithubs.Add(new Student("B10956042", " 陳昭諺", " https://github.com/B10956042"));
            studentGithubs.Add(new Student("B10956043", " 李卉欣", " https://github.com/huixin710"));
            studentGithubs.Add(new Student("B10956044", " 林孟翬", " https://github.com/LIN-MENG-HUI"));
            studentGithubs.Add(new Student("B10956045", " 陳軒霖", " https://github.com/B10956045"));
            studentGithubs.Add(new Student("B10956046", " 吳承翰", " https://github.com/Wu5002"));
            studentGithubs.Add(new Student("B10956047", " 黃雅筠", " https://github.com/b10956047"));
            studentGithubs.Add(new Student("B10956048", " 張景陽", " https://github.com/B10956048"));
            studentGithubs.Add(new Student("B10956049", " 洪頎崴", " https://github.com/wei20023802"));
            studentGithubs.Add(new Student("B10956050", " 謝心妍", " https://github.com/B10956050"));
            studentGithubs.Add(new Student("B10956051", " 林筱峰", ""));
            studentGithubs.Add(new Student("B10956052", " 梁瑋展", " https://github.com/B10956052"));
            studentGithubs.Add(new Student("B10956053", " 陳榆靜", " https://github.com/B10956053"));
            studentGithubs.Add(new Student("B10956054", " 何科橙", " https://github.com/B10956054"));
            studentGithubs.Add(new Student("B10956056", " 鄭羽軒", " https://github.com/B10956056"));
            studentGithubs.Add(new Student("B10956057", " 王裕成", " https://github.com/B10956057"));
            studentGithubs.Add(new Student("B10956058", " 劉念純", " https://github.com/b10956058"));
            studentGithubs.Add(new Student("B10956059", " 鄭佩甄", " https://github.com/B10956059"));
            studentGithubs.Add(new Student("B10956060", " 何冠德", " https://github.com/Guan-De"));
            studentGithubs.Add(new Student("B10956061", " 陳柏豪", "  https://github.com/Ken-Chen666"));
            studentGithubs.Add(new Student("B10956062", " 邱詩淯", " https://github.com/Iris-0402"));
            studentGithubs.Add(new Student("B10956063", " 呂書妤", " https://github.com/B10956063"));
            studentGithubs.Add(new Student("B10956065", " 陳鑫彰", " https://github.com/B10956065"));
            studentGithubs.Add(new Student("B10956250", " 薛丞涵", " https://github.com/xuechenghan"));
            studentGithubs.Add(new Student("B10756036", " 陳婉茹", ""));

        }

        public Student GetStudentByStudentNo(string studentNo)
        {
            return studentGithubs.FirstOrDefault(x => x.studentNo == studentNo);
        }

        public List<Student> GetStudents()
        {
            return studentGithubs.Where(x => !x.isDelete).ToList();
        }

        public (int total, List<Student>) GetStudents(int offset, int count)
        {
            return (studentGithubs.Count(x => !x.isDelete), studentGithubs.Where(x => !x.isDelete).Skip(offset).Take(count).ToList());
        }

        public  (int total, List<Student>) GetStudents(int offset, int count, Dictionary<string, string> queryDic)
        {
            var list = GetStudents();
            
            if (!string.IsNullOrWhiteSpace(queryDic["studentName"]))
            {
                list = list.Where(x => x.studentName.Contains(queryDic["studentName"])).ToList();
            }

            if (!string.IsNullOrWhiteSpace(queryDic["studentNo"]))
            {
                list = list.Where(x => x.studentNo.Contains(queryDic["studentNo"])).ToList();
            }

            if (!string.IsNullOrWhiteSpace(queryDic["githubLink"]))
            {
                list = list.Where(x => x.githubLink.Contains(queryDic["githubLink"])).ToList();
            }

            return (list.Count, list.Skip(offset).Take(count).ToList());

        }

        public bool UpdateStudent(Student student)
        {
            try
            {
                var data = studentGithubs.Find(x => x.studentNo == student.studentNo);
                data.studentName = student.studentName;
                data.githubLink = student.githubLink;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteStudent(string studentNo)
        {
            try
            {
                var data = studentGithubs.Find(x => x.studentNo == studentNo);
                data.isDelete = true;
                data.updateDateTime = DateTime.Now;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateStudent(Student student)
        {
            try
            {
                student.creDateTime = DateTime.Now;
                studentGithubs.Add(student);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
