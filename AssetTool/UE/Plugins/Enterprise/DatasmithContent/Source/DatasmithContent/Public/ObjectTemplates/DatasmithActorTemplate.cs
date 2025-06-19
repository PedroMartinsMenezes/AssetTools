namespace AssetTool
{
    [JsonAsset("DatasmithActorTemplate")]
    public class UDatasmithActorTemplate : UDatasmithObjectTemplate
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}