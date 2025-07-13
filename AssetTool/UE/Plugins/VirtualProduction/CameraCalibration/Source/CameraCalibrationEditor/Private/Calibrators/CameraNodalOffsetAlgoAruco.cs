namespace AssetTool
{
    [JsonAsset("CameraNodalOffsetAlgoAruco")]
    public class UCameraNodalOffsetAlgoAruco : UCameraNodalOffsetAlgoPoints
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}