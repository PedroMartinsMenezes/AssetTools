namespace AssetTool
{
    [JsonAsset("CineCameraRigRail")]
    public class ACineCameraRigRail : ACameraRig_Rail
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}