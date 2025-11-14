namespace AssetTool
{
    [JsonAsset("NavArea_Obstacle")]
    public class UNavArea_Obstacle : UNavArea
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}