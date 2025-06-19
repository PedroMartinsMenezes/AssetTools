namespace AssetTool
{
    [JsonAsset("NiagaraScriptFactoryNew")]
    public class UNiagaraScriptFactoryNew : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraModuleScriptFactory")]
    public class UNiagaraModuleScriptFactory : UNiagaraScriptFactoryNew
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraFunctionScriptFactory")]
    public class UNiagaraFunctionScriptFactory : UNiagaraScriptFactoryNew
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraDynamicInputScriptFactory")]
    public class UNiagaraDynamicInputScriptFactory : UNiagaraScriptFactoryNew
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}