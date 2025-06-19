namespace AssetTool
{
    [JsonAsset("ConvertLevelsToExternalActorsCommandlet")]
    public class UConvertLevelsToExternalActorsCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}