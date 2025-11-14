namespace AssetTool
{
    [JsonAsset("CameraNodalOffsetAlgoCheckerboard")]
    public class UCameraNodalOffsetAlgoCheckerboard : UCameraNodalOffsetAlgoPoints
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}