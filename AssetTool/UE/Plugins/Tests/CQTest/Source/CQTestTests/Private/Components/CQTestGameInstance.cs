namespace AssetTool
{
    [JsonAsset("CQGameInstanceClass")]
    public class UCQGameInstanceClass : UGameInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}