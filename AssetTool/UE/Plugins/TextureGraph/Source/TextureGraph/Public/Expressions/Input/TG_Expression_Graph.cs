namespace AssetTool
{
    [JsonAsset("TG_Expression_Graph")]
    public class UTG_Expression_Graph : UTG_Expression
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TG_Expression_TextureGraph")]
    public class UTG_Expression_TextureGraph : UTG_Expression_Graph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}