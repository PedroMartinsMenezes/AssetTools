namespace AssetTool
{
    [JsonAsset("CameraNodalOffsetAlgoOpticalAxis")]
    public class UCameraNodalOffsetAlgoOpticalAxis : UCameraNodalOffsetAlgoPoints
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}