namespace AssetTool
{
    [JsonAsset("NiagaraScript")]
    public class UNiagaraScript : UObject
    {
        public ENiagaraScriptUsage Usage = ENiagaraScriptUsage.ParticleGPUComputeScript;
        public List<FNiagaraShaderScript> LoadedResources;
        public FNiagaraVMExecutableData CachedScriptVM = new();
        public bool IsValidShaderScript;

        [Location("void UNiagaraScript::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            if (transfer.IsReading && transfer.GlobalObjects.CurrentObject.NextOffset > transfer.Position)
            {
                IsValidShaderScript = true;
            }

            SerializeNiagaraShaderMaps(transfer, IsValidShaderScript);
            return this;
        }

        [Location("void UNiagaraScript::SerializeNiagaraShaderMaps(FArchive& Ar, int32 NiagaraVer, bool IsValidShaderScript)")]
        private void SerializeNiagaraShaderMaps(Transfer transfer, bool IsValidShaderScript)
        {
            IsValidShaderScript = (transfer.Supports.NiagaraShaderMaps) && (!transfer.Supports.NiagaraShaderMapCooking || IsValidShaderScript);
            if (!IsValidShaderScript)
            {
                return;
            }
            bool HasEditorData = !transfer.GlobalObjects.IsFilterEditorOnly();
            if (HasEditorData)
            {
                transfer.Move(ref LoadedResources);
            }
        }
    }

    [TransferableStruct("NiagaraVMExecutableData")]
    public class FNiagaraVMExecutableData : ITransferable
    {
        public UScriptStruct scriptStruct = new();
        public ENiagaraScriptCompileStatus LastCompileStatus = ENiagaraScriptCompileStatus.NCS_UpToDate;
        public List<FNiagaraScriptDataInterfaceCompileInfo> DataInterfaceInfo = [];

        [Location("void FNiagaraVMExecutableData::SerializeData(FArchive& Ar, bool bDDCData)")]
        public ITransferable Move(Transfer transfer)
        {
            scriptStruct.SerializeTaggedProperties(transfer);
            return this;
        }

        public bool IsValid()
        {
            return LastCompileStatus != ENiagaraScriptCompileStatus.NCS_Unknown;
        }
    }
}