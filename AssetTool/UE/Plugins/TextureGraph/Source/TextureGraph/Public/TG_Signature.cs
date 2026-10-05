using static AssetTool.UTG_Pin;

namespace AssetTool
{
    public class FTG_Argument
    {
        public string TypeName;
        public ETG_Access Flags;

        public FTG_Argument() { }

        public FTG_Argument(Dictionary<string, object> tagMembers)
        {
            TypeName = GetCPPTypeName(tagMembers);
            Flags = GetFlags(tagMembers);
        }

        public bool IsPrivate()
        {
            return Flags.HasFlag(ETG_Access.PrivateBitMask);
        }

        public bool IsPersistentSelfVar()
        {
            return Flags.HasFlag(ETG_Access.PersistentSelfVarFlag);
        }

        private static string GetCPPTypeName(Dictionary<string, object> dict1)
        {
            if (dict1.FirstOrDefault(x => x.Key == "name 'CPPTypeName'").Value is string typeName)
            {
                return typeName;
            }
            return null;
        }

        private static ETG_Access GetFlags(Dictionary<string, object> dict1)
        {
            if (dict1.FirstOrDefault(x => x.Key.Contains("'ArgumentType'")).Value is Dictionary<string, object> dict2)
            {
                if (dict2.FirstOrDefault(x => x.Key == "uint 'Flags'").Value is uint flags)
                {
                    return (ETG_Access)flags;
                }
                else if (dict2.FirstOrDefault(x => x.Key == "uint 'Flags'").Value is TUInt32 flags2)
                {
                    return (ETG_Access)flags2.Value;
                }
            }
            return ETG_Access.In;
        }
    }
}
