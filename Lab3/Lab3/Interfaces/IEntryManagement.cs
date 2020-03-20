namespace Lab3.Interfaces
{
    interface IEntryManagement
    {
        Entry FindEntryByTitle(string title);
        Entry FindEntryById(uint id);
        void PrintAllEntries();
    }
}
