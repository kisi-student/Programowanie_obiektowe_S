using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Grade
    {
        private string _subject;
        private string _data;
        private double _value;

        public Grade()
        {
            _subject = "unknown";
            _data = "unknown";
            _value = 0.0;
        }

        public Grade(string _subject, string _data, double _value)
        {
            this._subject = _subject;
            this._data = _data;
            this._value = _value;
        }

        public void WriteInfo()
        {
            Console.WriteLine($"Subject, data and value {_subject},{_data},{_value}");
        }

        public double Value { get => _value; set => _value = value; }
        public string Data { get => _data; set => _data = value; }
        public string Subject { get => _subject; set => _subject = value; }
    }
}
