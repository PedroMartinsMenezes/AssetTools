namespace AssetTool
{
    [JsonAsset("AnimNextAnimationGraph")]
    public class UAnimNextAnimationGraph : UAnimNextDataInterface
    {
        public uint8[] SharedDataArchiveBuffer;

        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.AnimNextCombineParameterBlocksAndGraphs)
            {
                transfer.Move(ref SharedDataArchiveBuffer);
            }
            return this;
        }
    }
}