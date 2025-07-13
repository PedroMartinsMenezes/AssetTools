namespace AssetTool
{
    [JsonAsset("CameraNodalOffsetAlgoCheckerboard")]
    public class UCameraNodalOffsetAlgoCheckerboard : UCameraNodalOffsetAlgoPoints
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}