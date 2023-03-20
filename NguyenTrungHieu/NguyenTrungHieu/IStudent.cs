using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NguyenTrungHieu
{
    interface IStudent
    {
        int StudID { set; get; }
        string StudName { set; get; }
        string StudGender { set; get; }
        int StudAge { set; get; }
        string StudClass { set; get; }
        float StudAvgMark { get; }
        void Print();
    }
    public class Student : IStudent
    {
        public int StudID { set; get; }
        public string StudName { set; get; }
        public string StudGender { set; get; }
        public int StudAge { set; get; }
        public string StudClass { set; get; }
        public float StudAvgMark { private set; get; }
        public void Print()
        {
            Console.WriteLine($"StudID: {StudID}\nStudName: {StudName}\nStudGender: {StudGender}\nStudAge: {StudAge}\nStudClass: {StudClass}\nStudAvgMark: {StudAvgMark}");
            //Console.WriteLine("StudID: " + StudID);
            //Console.WriteLine("StudName: " + StudName);
            //Console.WriteLine("StudGender: " + StudGender);
            //Console.WriteLine("StudAge: " + StudAge);
            //Console.WriteLine("StudClass: " + StudClass);
            //Console.WriteLine("StudAvgMark: " + StudAvgMark);
        }
        public int[] MarkList = new int[3];
        public int this[int index]
        {
            get { return MarkList[index]; }
            set { MarkList[index] = value; }
        }
        public void CalAvg()
        {
            float total = 0;
            for (int i = 0; i <= MarkList.Length; i++)
            {
                total += MarkList[i];

            }
            StudAvgMark = total / MarkList.Length;
        }
        //List<Student> ListStudent = new List<Student>();
        private List<Student> ListStudent = null;
        public Student()
        {
            ListStudent = new List<Student>();
        }
        public void AddStud()
        {
            Student st = new Student();
            Console.Write("StudID: ");
            st.StudID = System.Int32.Parse(Console.ReadLine());
            Console.Write("StudName: ");
            st.StudName = Console.ReadLine();
            Console.Write("StudGender: ");
            st.StudGender = Console.ReadLine();
            Console.Write("StudAge: ");
            st.StudAge = System.Int32.Parse(Console.ReadLine());
            Console.Write("StudClass: ");
            st.StudClass = Console.ReadLine();
            Console.Write("StudAvgMark: ");
            for (int i = 0; i < MarkList.Length; i++)
            {
                Console.Write($"Mark {i}: ");
                MarkList[i] = Convert.ToInt32(Console.ReadLine());
            }
            ListStudent.Add(st);
        }
        public void ShowStud(List<Student> listSV)
        {
            if (listSV != null && listSV.Count > 0)
            {
                foreach (Student sv in listSV)
                {
                    Console.WriteLine($"\nStudID: {sv.StudID}\nStudName: {sv.StudName}\nStudGender: {sv.StudGender}\nStudAge: {sv.StudAge}\nStudClass: {sv.StudClass}\nStudAvgMark: {sv.StudAvgMark}");
                }
            }
            Console.WriteLine();
        }
        public List<Student> getListStudent()
        {
            return ListStudent;
        }
        public Student FindByID(int ID)
        {
            Student searchResult = null;
            if (ListStudent != null && ListStudent.Count > 0)
            {
                foreach (Student st in ListStudent)
                {
                    if (st.StudID == ID)
                    {
                        searchResult = st;
                    }
                }
            }
            return searchResult;
        }
        public List<Student> FindByName(String keyword)
        {
            List<Student> searchResult = new List<Student>();
            if (ListStudent != null && ListStudent.Count > 0)
            {
                foreach (Student sv in Student)
                {
                    if (sv.StudName.ToUpper().Contains(keyword.ToUpper()))
                    {
                        searchResult.Add(sv);
                    }
                }
            }
            return searchResult;
        }
    }
}
