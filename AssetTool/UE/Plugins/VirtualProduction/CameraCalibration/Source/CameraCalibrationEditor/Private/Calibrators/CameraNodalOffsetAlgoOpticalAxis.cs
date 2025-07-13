namespace AssetTool
{
    [JsonAsset("CameraNodalOffsetAlgoOpticalAxis")]
    public class UCameraNodalOffsetAlgoOpticalAxis : UCameraNodalOffsetAlgoPoints
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}