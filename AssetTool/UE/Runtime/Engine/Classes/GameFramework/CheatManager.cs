namespace AssetTool
{
    [JsonAsset("CheatManagerExtension")]
    public class UCheatManagerExtension : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CheatManager")]
    public class UCheatManager : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}