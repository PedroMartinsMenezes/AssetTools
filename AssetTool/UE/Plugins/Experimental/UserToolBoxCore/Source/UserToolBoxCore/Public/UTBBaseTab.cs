namespace AssetTool
{
    [JsonAsset("UTBTabSection")]
    public class UUTBTabSection : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UserToolBoxBaseTab")]
    public class UUserToolBoxBaseTab : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}