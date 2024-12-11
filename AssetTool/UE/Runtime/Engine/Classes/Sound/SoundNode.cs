namespace AssetTool
{
    [JsonAsset("SoundNode")]
    public class USoundNode : UObject
    {
        public FStripDataFlags StripFlags;
        public UInt32 GraphNode;

        [Location("void USoundNode::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            if (Supports.VER_UE4_COOKED_ASSETS_IN_EDITOR_SUPPORT)
            {
                transfer.Move(ref StripFlags);
                if (!StripFlags.IsEditorDataStripped())
                {
                    transfer.Move(ref GraphNode);
                }
            }
            else
            {
                transfer.Move(ref GraphNode);
            }

            return this;
        }
    }
}