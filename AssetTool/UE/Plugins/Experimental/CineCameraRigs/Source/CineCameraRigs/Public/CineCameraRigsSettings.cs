namespace AssetTool
{
    [JsonAsset("CineCameraRigRailSettings")]
    public class UCineCameraRigRailSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}