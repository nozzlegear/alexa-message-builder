﻿using System;
using System.Collections.Generic;
using AlexaMessageBuilder.Enums;
using AlexaMessageBuilder.Models;

namespace AlexaMessageBuilder
{
    public class MessageBuilder
    {
        public MessageBuilder()
        {

        }

        private Message Message = new Message();

        public MessageBuilder SetVersion(string version)
        {
            Message.Version = version;

            return this;
        }

        public MessageBuilder AddSessionAttribute(string key, object value)
        {
            if (Message.SessionAttributes != null)
            {
                Message.SessionAttributes = new Dictionary<string, object>();
            }

            Message.SessionAttributes.Add(key, value);

            return this;
        }

        public MessageBuilder SetOutputSpeech(SpeechType speechType, string speech, bool isReprompt)
        {
            Response response = Message.Response;

            if (isReprompt)
            {
                response.Reprompt = new Response();

                response = response.Reprompt;
            }

            response.OutputSpeech = new OutputSpeech(speechType);

            if (speechType == SpeechType.PlainText)
            {
                response.Text = speech;
            }
            else
            {
                response.SSML = speech;
            }

            return this;
        }

        public MessageBuilder SetPlainSpeech(string speech)
        {
            return SetOutputSpeech(SpeechType.PlainText, speech, false);
        }

        public MessageBuilder SetSSMLSpeech(string speech)
        {
            return SetOutputSpeech(SpeechType.SSML, speech, false);
        }

        public MessageBuilder SetRepromptPlainSpeech(string speech)
        {
            return SetOutputSpeech(SpeechType.PlainText, speech, true);
        }

        public MessageBuilder SetRepromptSSMLSpeech(string speech)
        {
            return SetOutputSpeech(SpeechType.SSML, speech, true);
        }

        public MessageBuilder SetKeepSession(bool keepSession)
        {
            this.Message.Response.ShouldEndSession = keepSession;

            return this;
        }

        public MessageBuilder SetSimpleCard()
        {
            return this;
        }

        public MessageBuilder SetStandardCard()
        {
            return this;
        }

        public Message BuildMessage()
        {
            return this.Message;
        }
    }
}