namespace AssetTool
{
    [JsonAsset("NiagaraStackEmitterPropertiesItem")]
    public class UNiagaraStackEmitterPropertiesItem : UNiagaraStackItem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackEmitterSummaryItem")]
    public class UNiagaraStackEmitterSummaryItem : UNiagaraStackItem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackEmitterSummaryGroup")]
    public class UNiagaraStackEmitterSummaryGroup : UNiagaraStackItemGroup
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackSummaryViewCollapseButton")]
    public class UNiagaraStackSummaryViewCollapseButton : UNiagaraStackEntry
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}