using System;

namespace CompareAssertMethods.Mock
{
    public class PersonMock
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Vorname { get; init; }

        public string Nachname { get; init; }

        public int Alter { get; init; }

        public PersonMock()
        {

        }

        public PersonMock(string vorname, string nachname, int alter)
        {
            Vorname = vorname;
            Nachname = nachname;
            Alter = alter;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj is not PersonMock other)
                return false;

            return other.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
