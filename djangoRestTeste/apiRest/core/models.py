# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models

# Create your models here.
class cliente(models.Model):
    nome = models.CharField(_(""), max_length=50)
    endereco = models.CharField(_(""), max_length=100)

