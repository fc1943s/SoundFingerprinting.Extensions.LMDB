﻿using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.CsProj;

namespace SoundFingerprinting.Extensions.LMDB.Benchmarks
{
    public class MultipleRuntimesConfig : ManualConfig
    {
        public MultipleRuntimesConfig()
        {
            Add(MemoryDiagnoser.Default);
            Add(Job.Default.With(CsProjCoreToolchain.NetCoreApp31).With(Platform.X64));
            Add(Job.Default.With(CsProjClassicNetToolchain.Net48).With(Platform.X64));

            Add(HtmlExporter.Default);
            Add(MarkdownExporter.GitHub);
            Add(RPlotExporter.Default);
        }
    }
}