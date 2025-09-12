using System;
using NetDeque;
using Xunit;

namespace NetDeque.Tests
{
    public class DequeTests
    {
        [Fact]
        public void NovoDeque_DeveComecarVazio()
        {
            var dq = new Deque<int>();
            Assert.Equal(0, dq.Count);
            Assert.True(dq.IsEmpty);
        }

        [Fact]
        public void AddNoInicio_DeveInserirNoComeco()
        {
            var dq = new Deque<int>();
            dq.AddBeg(10);

            Assert.False(dq.IsEmpty);
            Assert.Equal(1, dq.Count);
            Assert.Equal(10, dq.PeekBeg());
            Assert.Equal(10, dq.PeekEnd());
        }

        [Fact]
        public void AddNoInicio_VariosElementos_DeveRetornarNaOrdemInversa()
        {
            var dq = new Deque<int>();
            dq.AddBeg(1);
            dq.AddBeg(2);
            dq.AddBeg(3);

            Assert.Equal(3, dq.RemBeg());
            Assert.Equal(2, dq.RemBeg());
            Assert.Equal(1, dq.RemBeg());
            Assert.True(dq.IsEmpty);
        }

        [Fact]
        public void AddNoFinal_DeveInserirNoFim()
        {
            var dq = new Deque<int>();
            dq.AddEnd(10);

            Assert.False(dq.IsEmpty);
            Assert.Equal(1, dq.Count);
            Assert.Equal(10, dq.PeekBeg());
            Assert.Equal(10, dq.PeekEnd());
        }

        [Fact]
        public void AddNoFinal_VariosElementos_DeveRetornarNaMesmaOrdem()
        {
            var dq = new Deque<int>();
            dq.AddEnd(1);
            dq.AddEnd(2);
            dq.AddEnd(3);

            Assert.Equal(3, dq.RemEnd());
            Assert.Equal(2, dq.RemEnd());
            Assert.Equal(1, dq.RemEnd());
            Assert.True(dq.IsEmpty);
        }

        [Fact]
        public void RemoverDoInicio_Vazio_DeveLancarExcecao()
        {
            var dq = new Deque<int>();
            Assert.Throws<InvalidOperationException>(() => dq.RemBeg());
        }

        [Fact]
        public void RemoverDoInicio_DeveReduzirCountECorresponderOrdem()
        {
            var dq = new Deque<int>();
            dq.AddBeg(1);
            dq.AddBeg(2);
            dq.AddBeg(3);

            Assert.Equal(3, dq.RemBeg());
            Assert.Equal(2, dq.RemBeg());
            Assert.Equal(1, dq.RemBeg());
            Assert.True(dq.IsEmpty);
        }

        [Fact]
        public void RemoverDoFinal_Vazio_DeveLancarExcecao()
        {
            var dq = new Deque<int>();
            Assert.Throws<InvalidOperationException>(() => dq.RemEnd());
        }

        [Fact]
        public void RemoverDoFinal_DeveReduzirCountECorresponderOrdem()
        {
            var dq = new Deque<int>();
            dq.AddEnd(1);
            dq.AddEnd(2);
            dq.AddEnd(3);

            Assert.Equal(3, dq.RemEnd());
            Assert.Equal(2, dq.RemEnd());
            Assert.Equal(1, dq.RemEnd());
            Assert.True(dq.IsEmpty);
        }

       
    }
}
