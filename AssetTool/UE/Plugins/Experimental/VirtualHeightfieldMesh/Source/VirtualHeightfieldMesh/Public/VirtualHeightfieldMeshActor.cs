namespace AssetTool
{
    [JsonAsset("VirtualHeightfieldMesh")]
    public class AVirtualHeightfieldMesh : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}