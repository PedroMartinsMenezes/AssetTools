namespace AssetTool
{
    [JsonAsset("DatasmithActorTemplate")]
    public class UDatasmithActorTemplate : UDatasmithObjectTemplate
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}