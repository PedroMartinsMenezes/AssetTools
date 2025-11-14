namespace AssetTool
{
    [JsonAsset("UTBTabSection")]
    public class UUTBTabSection : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UserToolBoxBaseTab")]
    public class UUserToolBoxBaseTab : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}