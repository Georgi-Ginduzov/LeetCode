public class Solution {
    public int NumUniqueEmails(string[] emails) {
        HashSet<string> mails = new HashSet<string>();
        foreach(var email in emails)
        {
            StringBuilder mail = new StringBuilder();
            for(int i = 0; i < email.Length-4; i++)
            {  
                switch(email[i])
                {
                    case '.':
                        continue;
                    case '+':
                        while(++i < email.Length && email[i] != '@')
                        {}
                        if(i < email.Length)
                        {      
                            mail.Append(email.Substring(i));
                            i = email.Length;
                        }
                        continue;
                    case '@':
                        mail.Append(email.Substring(i));
                        i = email.Length;
                        continue;
                    default:
                        mail.Append(email[i]);
                        continue;
                }
            }
            if(mail.Length > 0)
            {
                mails.Add(mail.ToString());
            }
        }
        return mails.Count;
    }
}