namespace AssetTool
{
    [JsonAsset("DatasmithActorTemplate")]
    public class UDatasmithActorTemplate : UDatasmithObjectTemplate
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}