namespace Managers
{
    internal interface IAssistantManager
    {
        public Assistant FetchAssistant(string assistantId);
        public List<Assistant> FetchAssistantForUser(string userId);
        public List<Assistant> FetchAssistantForUser(User user) => FetchAssistantForUser(user.Id);
        public bool DeleteAllAssistantForUser(string userId);
        public bool DeleteAllAssistantForUser(User user) => DeleteAllAssistantForUser(user.Id);
    }
}
