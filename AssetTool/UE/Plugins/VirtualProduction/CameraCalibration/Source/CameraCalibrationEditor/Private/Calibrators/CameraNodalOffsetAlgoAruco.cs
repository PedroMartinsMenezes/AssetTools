namespace AssetTool
{
    [JsonAsset("CameraNodalOffsetAlgoAruco")]
    public class UCameraNodalOffsetAlgoAruco : UCameraNodalOffsetAlgoPoints
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}