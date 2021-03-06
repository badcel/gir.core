﻿using Bullseye;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Build.Test
{
    [TestClass]
    public class RunnerTest
    {
        #region Helper

        private static Runner GetRunner(ITarget? clean = null, ITarget? generate = null, ITarget? build = null, ITarget? pack = null, ITarget? samples = null, ITarget? test = null, ITarget? integration = null)
        {
            clean ??= Mock.Of<ITarget>();
            generate ??= Mock.Of<ITarget>();
            samples ??= Mock.Of<ITarget>();
            build ??= Mock.Of<ITarget>();
            pack ??= Mock.Of<ITarget>();
            test ??= Mock.Of<ITarget>();
            integration ??= Mock.Of<ITarget>();

            return new Runner(clean, generate, build, pack, samples, test, integration);
        }

        private static void RunTarget(Runner runner, string target)
        {
            runner.Run(new[] {target}, null!);
        }

        #endregion

        [TestMethod]
        public void InvokingCleanTargetExecutesProjectCleaner()
        {
            var target = Mock.Of<ITarget>();

            Runner runner = GetRunner(
                clean: target
            );

            RunTarget(runner, "clean");

            Mock.Get(target).Verify((x) => x.Execute(), Times.Once);
        }

        [TestMethod]
        public void InvokingGenerateTargetExecutesLibraryGenerator()
        {
            var target = Mock.Of<ITarget>();

            Runner runner = GetRunner(
                generate: target
            );

            RunTarget(runner, "generate");

            Mock.Get(target).Verify((x) => x.Execute(), Times.Once);
        }
        
        [TestMethod]
        public void InvokingIntegrationTargetExecutesIntegrationBuilder()
        {
            var target = Mock.Of<ITarget>();

            Runner runner = GetRunner(
                integration: target
            );

            RunTarget(runner, "integration");

            Mock.Get(target).Verify((x) => x.Execute(), Times.Once);
        }

        [TestMethod]
        [DataRow("build")]
        [DataRow("default")] //Default target is equal to build target
        public void InvokingBuildTargetExecutesLibraryGeneratorAndLibraryBuilder(string target)
        {
            var generate = Mock.Of<ITarget>();
            var build = Mock.Of<ITarget>();

            Runner runner = GetRunner(
                generate: generate,
                build: build
            );

            RunTarget(runner, target);

            Mock.Get(generate).Verify((x) => x.Execute(), Times.Once);
            Mock.Get(build).Verify((x) => x.Execute(), Times.Once);
        }

        [TestMethod]
        public void InvokingSamplesTargetExecutesLibraryBuilderIntegrationBuilderSampleBuilder()
        {
            var samples = Mock.Of<ITarget>();
            var build = Mock.Of<ITarget>();
            var integration = Mock.Of<ITarget>();
            
            Runner runner = GetRunner(
                build: build,
                samples: samples,
                integration: integration
            );

            RunTarget(runner, "samples");

            Mock.Get(integration).Verify(x => x.Execute(), Times.Once);
            Mock.Get(build).Verify((x) => x.Execute(), Times.Once);
            Mock.Get(samples).Verify((x) => x.Execute(), Times.Once);
        }
        
        [TestMethod]
        public void InvokingTestTargetExecutesLibraryBuilderAndTester()
        {
            var build = Mock.Of<ITarget>();
            var test = Mock.Of<ITarget>();
            
            Runner runner = GetRunner(
                build: build,
                test: test
            );

            RunTarget(runner, "test");

            Mock.Get(build).Verify((x) => x.Execute(), Times.Once);
            Mock.Get(test).Verify((x) => x.Execute(), Times.Once);
        }
        
        [TestMethod]
        public void InvokingPackTargetExecutesLibraryBuilderAndPacker()
        {
            var build = Mock.Of<ITarget>();
            var pack = Mock.Of<ITarget>();
            
            Runner runner = GetRunner(
                build: build,
                pack: pack
            );

            RunTarget(runner, "pack");

            Mock.Get(build).Verify((x) => x.Execute(), Times.Once);
            Mock.Get(pack).Verify((x) => x.Execute(), Times.Once);
        }
    }
}
