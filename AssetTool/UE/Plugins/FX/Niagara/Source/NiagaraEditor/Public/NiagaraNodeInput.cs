namespace AssetTool
{
    [JsonAsset("NiagaraNodeInput")]
    public class UNiagaraNodeInput : UNiagaraNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}