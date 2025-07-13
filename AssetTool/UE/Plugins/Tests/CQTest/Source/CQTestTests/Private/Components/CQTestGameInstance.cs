namespace AssetTool
{
    [JsonAsset("CQGameInstanceClass")]
    public class UCQGameInstanceClass : UGameInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}