namespace AssetTool
{
    [JsonAsset("DatasmithLandscapeTemplate")]
    public class UDatasmithLandscapeTemplate : UDatasmithObjectTemplate
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}